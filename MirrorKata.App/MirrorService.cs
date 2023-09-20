namespace MirrorKata.App
{
    public static class MirrorService
    {
        /// <summary>
        /// Returns the mirror version of the time.
        /// </summary>
        /// <param name="time">Time in format "XX:XX"</param>
        /// <returns>Mirrored time in format "XX:XX"</returns>
        public static string GetMirroredTime(string time)
        {
            if (!TimeSpan.TryParseExact(time, @"hh\:mm", null, out var parsedTime))
            {
                throw new InvalidDataException("Provided time is not in valid format.");
            }
            
            if (parsedTime.Hours >= 12)
            {
                parsedTime = parsedTime.Add(TimeSpan.FromHours(-12));
            }

            var mirroredTime = TimeSpan.FromMinutes(Math.Abs(parsedTime.TotalMinutes - TimeSpan.FromHours(12).TotalMinutes));

            if (mirroredTime.Hours == 0)
            {
                mirroredTime = mirroredTime.Add(TimeSpan.FromHours(12));
            }

            return mirroredTime.ToString(@"hh\:mm");
        }
    }
}
