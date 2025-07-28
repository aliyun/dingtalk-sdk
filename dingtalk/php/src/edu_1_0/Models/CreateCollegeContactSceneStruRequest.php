<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCollegeContactSceneStruRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $hasStruFixedDept;

    /**
     * @example 20
     *
     * @var int
     */
    public $order;

    /**
     * @example 场景架构标识
     *
     * @var string
     */
    public $sourceIdentifier;

    /**
     * @example 这是场景架构简介
     *
     * @var string
     */
    public $struBrief;

    /**
     * @description This parameter is required.
     *
     * @example 科研架构
     *
     * @var string
     */
    public $struName;

    /**
     * @description This parameter is required.
     *
     * @example stru_research_dept
     *
     * @var string
     */
    public $struType;
    protected $_name = [
        'hasStruFixedDept' => 'hasStruFixedDept',
        'order' => 'order',
        'sourceIdentifier' => 'sourceIdentifier',
        'struBrief' => 'struBrief',
        'struName' => 'struName',
        'struType' => 'struType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasStruFixedDept) {
            $res['hasStruFixedDept'] = $this->hasStruFixedDept;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->sourceIdentifier) {
            $res['sourceIdentifier'] = $this->sourceIdentifier;
        }
        if (null !== $this->struBrief) {
            $res['struBrief'] = $this->struBrief;
        }
        if (null !== $this->struName) {
            $res['struName'] = $this->struName;
        }
        if (null !== $this->struType) {
            $res['struType'] = $this->struType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCollegeContactSceneStruRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasStruFixedDept'])) {
            $model->hasStruFixedDept = $map['hasStruFixedDept'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['sourceIdentifier'])) {
            $model->sourceIdentifier = $map['sourceIdentifier'];
        }
        if (isset($map['struBrief'])) {
            $model->struBrief = $map['struBrief'];
        }
        if (isset($map['struName'])) {
            $model->struName = $map['struName'];
        }
        if (isset($map['struType'])) {
            $model->struType = $map['struType'];
        }

        return $model;
    }
}
