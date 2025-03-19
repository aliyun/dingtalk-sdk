<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class baseInfo extends Model
{
    /**
     * @example 18
     *
     * @var int
     */
    public $age;

    /**
     * @example http://www.xxxx.com
     *
     * @var string
     */
    public $avatar;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $beginWorkTime;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $birthday;

    /**
     * @example xxxxxxx@alibaba-inc.com
     *
     * @var string
     */
    public $email;

    /**
     * @example Jason
     *
     * @var string
     */
    public $englishName;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $graduateTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $highestEducation;

    /**
     * @example java开发工程师
     *
     * @var string
     */
    public $jobTitle;

    /**
     * @example 清华大学
     *
     * @var string
     */
    public $lastSchoolName;

    /**
     * @example 1
     *
     * @var int
     */
    public $married;

    /**
     * @description This parameter is required.
     *
     * @example 孙先生
     *
     * @var string
     */
    public $name;

    /**
     * @example 浙江省杭州市余杭区仓前街道
     *
     * @var string
     */
    public $nativePlace;

    /**
     * @example 浙江省杭州市余杭区仓前街道欧美金融城
     *
     * @var string
     */
    public $nowLocation;

    /**
     * @example 曾获得xxx比赛xxx奖项
     *
     * @var string
     */
    public $personalHonor;

    /**
     * @example 187xxxxxxxx
     *
     * @var string
     */
    public $phoneNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $politicalStatus;

    /**
     * @example 沟通能力强......
     *
     * @var string
     */
    public $selfEvaluation;

    /**
     * @example 1
     *
     * @var int
     */
    public $sex;

    /**
     * @example 187xxxxxxxx
     *
     * @var string
     */
    public $virtualPhoneNum;

    /**
     * @example 3
     *
     * @var int
     */
    public $workingYears;
    protected $_name = [
        'age' => 'age',
        'avatar' => 'avatar',
        'beginWorkTime' => 'beginWorkTime',
        'birthday' => 'birthday',
        'email' => 'email',
        'englishName' => 'englishName',
        'graduateTime' => 'graduateTime',
        'highestEducation' => 'highestEducation',
        'jobTitle' => 'jobTitle',
        'lastSchoolName' => 'lastSchoolName',
        'married' => 'married',
        'name' => 'name',
        'nativePlace' => 'nativePlace',
        'nowLocation' => 'nowLocation',
        'personalHonor' => 'personalHonor',
        'phoneNum' => 'phoneNum',
        'politicalStatus' => 'politicalStatus',
        'selfEvaluation' => 'selfEvaluation',
        'sex' => 'sex',
        'virtualPhoneNum' => 'virtualPhoneNum',
        'workingYears' => 'workingYears',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->age) {
            $res['age'] = $this->age;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->beginWorkTime) {
            $res['beginWorkTime'] = $this->beginWorkTime;
        }
        if (null !== $this->birthday) {
            $res['birthday'] = $this->birthday;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->englishName) {
            $res['englishName'] = $this->englishName;
        }
        if (null !== $this->graduateTime) {
            $res['graduateTime'] = $this->graduateTime;
        }
        if (null !== $this->highestEducation) {
            $res['highestEducation'] = $this->highestEducation;
        }
        if (null !== $this->jobTitle) {
            $res['jobTitle'] = $this->jobTitle;
        }
        if (null !== $this->lastSchoolName) {
            $res['lastSchoolName'] = $this->lastSchoolName;
        }
        if (null !== $this->married) {
            $res['married'] = $this->married;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nativePlace) {
            $res['nativePlace'] = $this->nativePlace;
        }
        if (null !== $this->nowLocation) {
            $res['nowLocation'] = $this->nowLocation;
        }
        if (null !== $this->personalHonor) {
            $res['personalHonor'] = $this->personalHonor;
        }
        if (null !== $this->phoneNum) {
            $res['phoneNum'] = $this->phoneNum;
        }
        if (null !== $this->politicalStatus) {
            $res['politicalStatus'] = $this->politicalStatus;
        }
        if (null !== $this->selfEvaluation) {
            $res['selfEvaluation'] = $this->selfEvaluation;
        }
        if (null !== $this->sex) {
            $res['sex'] = $this->sex;
        }
        if (null !== $this->virtualPhoneNum) {
            $res['virtualPhoneNum'] = $this->virtualPhoneNum;
        }
        if (null !== $this->workingYears) {
            $res['workingYears'] = $this->workingYears;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return baseInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['age'])) {
            $model->age = $map['age'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['beginWorkTime'])) {
            $model->beginWorkTime = $map['beginWorkTime'];
        }
        if (isset($map['birthday'])) {
            $model->birthday = $map['birthday'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['englishName'])) {
            $model->englishName = $map['englishName'];
        }
        if (isset($map['graduateTime'])) {
            $model->graduateTime = $map['graduateTime'];
        }
        if (isset($map['highestEducation'])) {
            $model->highestEducation = $map['highestEducation'];
        }
        if (isset($map['jobTitle'])) {
            $model->jobTitle = $map['jobTitle'];
        }
        if (isset($map['lastSchoolName'])) {
            $model->lastSchoolName = $map['lastSchoolName'];
        }
        if (isset($map['married'])) {
            $model->married = $map['married'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nativePlace'])) {
            $model->nativePlace = $map['nativePlace'];
        }
        if (isset($map['nowLocation'])) {
            $model->nowLocation = $map['nowLocation'];
        }
        if (isset($map['personalHonor'])) {
            $model->personalHonor = $map['personalHonor'];
        }
        if (isset($map['phoneNum'])) {
            $model->phoneNum = $map['phoneNum'];
        }
        if (isset($map['politicalStatus'])) {
            $model->politicalStatus = $map['politicalStatus'];
        }
        if (isset($map['selfEvaluation'])) {
            $model->selfEvaluation = $map['selfEvaluation'];
        }
        if (isset($map['sex'])) {
            $model->sex = $map['sex'];
        }
        if (isset($map['virtualPhoneNum'])) {
            $model->virtualPhoneNum = $map['virtualPhoneNum'];
        }
        if (isset($map['workingYears'])) {
            $model->workingYears = $map['workingYears'];
        }

        return $model;
    }
}
