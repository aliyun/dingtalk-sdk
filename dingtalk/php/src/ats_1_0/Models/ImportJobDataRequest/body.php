<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataRequest;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataRequest\body\address;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataRequest\body\fullTimeExt;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var address
     */
    public $address;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $category;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $experience;

    /**
     * @var fullTimeExt
     */
    public $fullTimeExt;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $jobNature;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxSalary;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $minSalary;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $requiredEdu;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'address'     => 'address',
        'category'    => 'category',
        'description' => 'description',
        'experience'  => 'experience',
        'fullTimeExt' => 'fullTimeExt',
        'jobNature'   => 'jobNature',
        'maxSalary'   => 'maxSalary',
        'minSalary'   => 'minSalary',
        'name'        => 'name',
        'requiredEdu' => 'requiredEdu',
        'userId'      => 'userId',
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
        if (null !== $this->experience) {
            $res['experience'] = $this->experience;
        }
        if (null !== $this->fullTimeExt) {
            $res['fullTimeExt'] = null !== $this->fullTimeExt ? $this->fullTimeExt->toMap() : null;
        }
        if (null !== $this->jobNature) {
            $res['jobNature'] = $this->jobNature;
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
        if (null !== $this->requiredEdu) {
            $res['requiredEdu'] = $this->requiredEdu;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
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
        if (isset($map['experience'])) {
            $model->experience = $map['experience'];
        }
        if (isset($map['fullTimeExt'])) {
            $model->fullTimeExt = fullTimeExt::fromMap($map['fullTimeExt']);
        }
        if (isset($map['jobNature'])) {
            $model->jobNature = $map['jobNature'];
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
        if (isset($map['requiredEdu'])) {
            $model->requiredEdu = $map['requiredEdu'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
