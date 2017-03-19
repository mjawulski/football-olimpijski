export class User {
    name: string;
    avatar: string;
    isAttendingToNextMatch: boolean;

    constructor(name: string, avatar: string) {
        this.name = name;
        this.avatar = avatar;
    }
}