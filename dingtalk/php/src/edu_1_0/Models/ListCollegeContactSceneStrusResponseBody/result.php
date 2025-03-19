<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSceneStrusResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $enable;

    /**
     * @var bool
     */
    public $hasStruFixedDept;

    /**
     * @example 这是科研架构简介
     *
     * @var string
     */
    public $struBrief;

    /**
     * @example 20
     *
     * @var int
     */
    public $struId;

    /**
     * @example 科研架构
     *
     * @var string
     */
    public $struName;

    /**
     * @example stru_research_dept
     *
     * @var string
     */
    public $struType;

    /**
     * @example 20
     *
     * @var int
     */
    public $studentDeptId;

    /**
     * @example 20
     *
     * @var int
     */
    public $teacherDeptId;
    protected $_name = [
        'enable' => 'enable',
        'hasStruFixedDept' => 'hasStruFixedDept',
        'struBrief' => 'struBrief',
        'struId' => 'struId',
        'struName' => 'struName',
        'struType' => 'struType',
        'studentDeptId' => 'studentDeptId',
        'teacherDeptId' => 'teacherDeptId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enable) {
            $res['enable'] = $this->enable;
        }
        if (null !== $this->hasStruFixedDept) {
            $res['hasStruFixedDept'] = $this->hasStruFixedDept;
        }
        if (null !== $this->struBrief) {
            $res['struBrief'] = $this->struBrief;
        }
        if (null !== $this->struId) {
            $res['struId'] = $this->struId;
        }
        if (null !== $this->struName) {
            $res['struName'] = $this->struName;
        }
        if (null !== $this->struType) {
            $res['struType'] = $this->struType;
        }
        if (null !== $this->studentDeptId) {
            $res['studentDeptId'] = $this->studentDeptId;
        }
        if (null !== $this->teacherDeptId) {
            $res['teacherDeptId'] = $this->teacherDeptId;
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
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
        }
        if (isset($map['hasStruFixedDept'])) {
            $model->hasStruFixedDept = $map['hasStruFixedDept'];
        }
        if (isset($map['struBrief'])) {
            $model->struBrief = $map['struBrief'];
        }
        if (isset($map['struId'])) {
            $model->struId = $map['struId'];
        }
        if (isset($map['struName'])) {
            $model->struName = $map['struName'];
        }
        if (isset($map['struType'])) {
            $model->struType = $map['struType'];
        }
        if (isset($map['studentDeptId'])) {
            $model->studentDeptId = $map['studentDeptId'];
        }
        if (isset($map['teacherDeptId'])) {
            $model->teacherDeptId = $map['teacherDeptId'];
        }

        return $model;
    }
}
