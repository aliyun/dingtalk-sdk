<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetChildrenResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetChildrenResponseBody\result\bindStudents;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bindStudents[]
     */
    public $bindStudents;

    /**
     * @example 杭州市
     *
     * @var string
     */
    public $city;

    /**
     * @example 西湖区
     *
     * @var string
     */
    public $district;

    /**
     * @example 1
     *
     * @var int
     */
    public $gradeLevel;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example primary_school
     *
     * @var string
     */
    public $periodCode;

    /**
     * @example 浙江省
     *
     * @var string
     */
    public $province;

    /**
     * @example 330106
     *
     * @var string
     */
    public $regionId;
    protected $_name = [
        'bindStudents' => 'bindStudents',
        'city'         => 'city',
        'district'     => 'district',
        'gradeLevel'   => 'gradeLevel',
        'name'         => 'name',
        'periodCode'   => 'periodCode',
        'province'     => 'province',
        'regionId'     => 'regionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindStudents) {
            $res['bindStudents'] = [];
            if (null !== $this->bindStudents && \is_array($this->bindStudents)) {
                $n = 0;
                foreach ($this->bindStudents as $item) {
                    $res['bindStudents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->district) {
            $res['district'] = $this->district;
        }
        if (null !== $this->gradeLevel) {
            $res['gradeLevel'] = $this->gradeLevel;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->province) {
            $res['province'] = $this->province;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindStudents'])) {
            if (!empty($map['bindStudents'])) {
                $model->bindStudents = [];
                $n                   = 0;
                foreach ($map['bindStudents'] as $item) {
                    $model->bindStudents[$n++] = null !== $item ? bindStudents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['district'])) {
            $model->district = $map['district'];
        }
        if (isset($map['gradeLevel'])) {
            $model->gradeLevel = $map['gradeLevel'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }

        return $model;
    }
}
