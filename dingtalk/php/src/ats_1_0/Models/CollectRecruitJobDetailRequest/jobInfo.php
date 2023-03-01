<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo\address;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo\fullTimeInfo;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo\partTimeInfo;
use AlibabaCloud\Tea\Model;

class jobInfo extends Model
{
    /**
     * @description 地址信息
     *
     * @var address
     */
    public $address;

    /**
     * @description 职位分类编码
     *
     * @var string
     */
    public $category;

    /**
     * @description 职位描述
     *
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $extInfo;

    /**
     * @description 全职信息
     *
     * @var fullTimeInfo
     */
    public $fullTimeInfo;

    /**
     * @description 招聘人数
     *
     * @var string
     */
    public $headCount;

    /**
     * @description 职位性质
     *
     * @var string
     */
    public $jobNature;

    /**
     * @description 职位标签，字符串列表
     *
     * @var string[]
     */
    public $jobTags;

    /**
     * @description 最高薪资
     *
     * @var string
     */
    public $maxSalary;

    /**
     * @description 最低薪资
     *
     * @var string
     */
    public $minSalary;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 渠道职位ID
     *
     * @var string
     */
    public $outJobId;

    /**
     * @description 兼职信息
     *
     * @var partTimeInfo
     */
    public $partTimeInfo;

    /**
     * @description 学历要求
     *
     * @var string
     */
    public $requiredEdu;
    protected $_name = [
        'address'      => 'address',
        'category'     => 'category',
        'description'  => 'description',
        'extInfo'      => 'extInfo',
        'fullTimeInfo' => 'fullTimeInfo',
        'headCount'    => 'headCount',
        'jobNature'    => 'jobNature',
        'jobTags'      => 'jobTags',
        'maxSalary'    => 'maxSalary',
        'minSalary'    => 'minSalary',
        'name'         => 'name',
        'outJobId'     => 'outJobId',
        'partTimeInfo' => 'partTimeInfo',
        'requiredEdu'  => 'requiredEdu',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = null !== $this->address ? $this->address->toMap() : null;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->fullTimeInfo) {
            $res['fullTimeInfo'] = null !== $this->fullTimeInfo ? $this->fullTimeInfo->toMap() : null;
        }
        if (null !== $this->headCount) {
            $res['headCount'] = $this->headCount;
        }
        if (null !== $this->jobNature) {
            $res['jobNature'] = $this->jobNature;
        }
        if (null !== $this->jobTags) {
            $res['jobTags'] = $this->jobTags;
        }
        if (null !== $this->maxSalary) {
            $res['maxSalary'] = $this->maxSalary;
        }
        if (null !== $this->minSalary) {
            $res['minSalary'] = $this->minSalary;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outJobId) {
            $res['outJobId'] = $this->outJobId;
        }
        if (null !== $this->partTimeInfo) {
            $res['partTimeInfo'] = null !== $this->partTimeInfo ? $this->partTimeInfo->toMap() : null;
        }
        if (null !== $this->requiredEdu) {
            $res['requiredEdu'] = $this->requiredEdu;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return jobInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = address::fromMap($map['address']);
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['fullTimeInfo'])) {
            $model->fullTimeInfo = fullTimeInfo::fromMap($map['fullTimeInfo']);
        }
        if (isset($map['headCount'])) {
            $model->headCount = $map['headCount'];
        }
        if (isset($map['jobNature'])) {
            $model->jobNature = $map['jobNature'];
        }
        if (isset($map['jobTags'])) {
            if (!empty($map['jobTags'])) {
                $model->jobTags = $map['jobTags'];
            }
        }
        if (isset($map['maxSalary'])) {
            $model->maxSalary = $map['maxSalary'];
        }
        if (isset($map['minSalary'])) {
            $model->minSalary = $map['minSalary'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outJobId'])) {
            $model->outJobId = $map['outJobId'];
        }
        if (isset($map['partTimeInfo'])) {
            $model->partTimeInfo = partTimeInfo::fromMap($map['partTimeInfo']);
        }
        if (isset($map['requiredEdu'])) {
            $model->requiredEdu = $map['requiredEdu'];
        }

        return $model;
    }
}
