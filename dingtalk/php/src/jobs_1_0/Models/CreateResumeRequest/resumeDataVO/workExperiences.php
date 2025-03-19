<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;

use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\workExperiences\resumePrivacy;
use AlibabaCloud\Tea\Model;

class workExperiences extends Model
{
    /**
     * @var string
     */
    public $achievement;

    /**
     * @var string
     */
    public $companyCode;

    /**
     * @var string
     */
    public $companyName;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $endDate;

    /**
     * @var string
     */
    public $industry;

    /**
     * @var string
     */
    public $industryCode;

    /**
     * @var bool
     */
    public $internship;

    /**
     * @var string
     */
    public $jobCode;

    /**
     * @var string
     */
    public $jobNature;

    /**
     * @var string
     */
    public $jobTitle;

    /**
     * @var string
     */
    public $leader;

    /**
     * @var string
     */
    public $location;

    /**
     * @var string
     */
    public $locationCode;

    /**
     * @var string
     */
    public $parentIndustry;

    /**
     * @var string
     */
    public $parentIndustryCode;

    /**
     * @var string
     */
    public $reasonOfLeaving;

    /**
     * @var string
     */
    public $responsibility;

    /**
     * @var resumePrivacy
     */
    public $resumePrivacy;

    /**
     * @var string
     */
    public $salary;

    /**
     * @var string[]
     */
    public $selectedSkillOptions;

    /**
     * @var string
     */
    public $startDate;

    /**
     * @var string
     */
    public $underlingNumber;
    protected $_name = [
        'achievement' => 'achievement',
        'companyCode' => 'companyCode',
        'companyName' => 'companyName',
        'description' => 'description',
        'endDate' => 'endDate',
        'industry' => 'industry',
        'industryCode' => 'industryCode',
        'internship' => 'internship',
        'jobCode' => 'jobCode',
        'jobNature' => 'jobNature',
        'jobTitle' => 'jobTitle',
        'leader' => 'leader',
        'location' => 'location',
        'locationCode' => 'locationCode',
        'parentIndustry' => 'parentIndustry',
        'parentIndustryCode' => 'parentIndustryCode',
        'reasonOfLeaving' => 'reasonOfLeaving',
        'responsibility' => 'responsibility',
        'resumePrivacy' => 'resumePrivacy',
        'salary' => 'salary',
        'selectedSkillOptions' => 'selectedSkillOptions',
        'startDate' => 'startDate',
        'underlingNumber' => 'underlingNumber',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->achievement) {
            $res['achievement'] = $this->achievement;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->internship) {
            $res['internship'] = $this->internship;
        }
        if (null !== $this->jobCode) {
            $res['jobCode'] = $this->jobCode;
        }
        if (null !== $this->jobNature) {
            $res['jobNature'] = $this->jobNature;
        }
        if (null !== $this->jobTitle) {
            $res['jobTitle'] = $this->jobTitle;
        }
        if (null !== $this->leader) {
            $res['leader'] = $this->leader;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->locationCode) {
            $res['locationCode'] = $this->locationCode;
        }
        if (null !== $this->parentIndustry) {
            $res['parentIndustry'] = $this->parentIndustry;
        }
        if (null !== $this->parentIndustryCode) {
            $res['parentIndustryCode'] = $this->parentIndustryCode;
        }
        if (null !== $this->reasonOfLeaving) {
            $res['reasonOfLeaving'] = $this->reasonOfLeaving;
        }
        if (null !== $this->responsibility) {
            $res['responsibility'] = $this->responsibility;
        }
        if (null !== $this->resumePrivacy) {
            $res['resumePrivacy'] = null !== $this->resumePrivacy ? $this->resumePrivacy->toMap() : null;
        }
        if (null !== $this->salary) {
            $res['salary'] = $this->salary;
        }
        if (null !== $this->selectedSkillOptions) {
            $res['selectedSkillOptions'] = $this->selectedSkillOptions;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->underlingNumber) {
            $res['underlingNumber'] = $this->underlingNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workExperiences
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['achievement'])) {
            $model->achievement = $map['achievement'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['internship'])) {
            $model->internship = $map['internship'];
        }
        if (isset($map['jobCode'])) {
            $model->jobCode = $map['jobCode'];
        }
        if (isset($map['jobNature'])) {
            $model->jobNature = $map['jobNature'];
        }
        if (isset($map['jobTitle'])) {
            $model->jobTitle = $map['jobTitle'];
        }
        if (isset($map['leader'])) {
            $model->leader = $map['leader'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['locationCode'])) {
            $model->locationCode = $map['locationCode'];
        }
        if (isset($map['parentIndustry'])) {
            $model->parentIndustry = $map['parentIndustry'];
        }
        if (isset($map['parentIndustryCode'])) {
            $model->parentIndustryCode = $map['parentIndustryCode'];
        }
        if (isset($map['reasonOfLeaving'])) {
            $model->reasonOfLeaving = $map['reasonOfLeaving'];
        }
        if (isset($map['responsibility'])) {
            $model->responsibility = $map['responsibility'];
        }
        if (isset($map['resumePrivacy'])) {
            $model->resumePrivacy = resumePrivacy::fromMap($map['resumePrivacy']);
        }
        if (isset($map['salary'])) {
            $model->salary = $map['salary'];
        }
        if (isset($map['selectedSkillOptions'])) {
            if (!empty($map['selectedSkillOptions'])) {
                $model->selectedSkillOptions = $map['selectedSkillOptions'];
            }
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['underlingNumber'])) {
            $model->underlingNumber = $map['underlingNumber'];
        }

        return $model;
    }
}
