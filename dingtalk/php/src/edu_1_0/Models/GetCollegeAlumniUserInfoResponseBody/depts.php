<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniUserInfoResponseBody;

use AlibabaCloud\Tea\Model;

class depts extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $deptId;

    /**
     * @var bool
     */
    public $hasSubDept;

    /**
     * @var bool
     */
    public $isIndustryDept;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'corpId'         => 'corpId',
        'deptId'         => 'deptId',
        'hasSubDept'     => 'hasSubDept',
        'isIndustryDept' => 'isIndustryDept',
        'name'           => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->hasSubDept) {
            $res['hasSubDept'] = $this->hasSubDept;
        }
        if (null !== $this->isIndustryDept) {
            $res['isIndustryDept'] = $this->isIndustryDept;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return depts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['hasSubDept'])) {
            $model->hasSubDept = $map['hasSubDept'];
        }
        if (isset($map['isIndustryDept'])) {
            $model->isIndustryDept = $map['isIndustryDept'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
