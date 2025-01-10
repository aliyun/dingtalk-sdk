<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalFieldMetaDTO extends Model
{
    /**
     * @description 是否启用
     *
     * This parameter is required.
     * @example true
     *
     * @var bool
     */
    public $active;

    /**
     * @description 字段元数据别名
     *
     * @example 字段别名
     *
     * @var string
     */
    public $alias;

    /**
     * @description 字段元数据标识
     *
     * This parameter is required.
     * @example foo
     *
     * @var string
     */
    public $code;

    /**
     * @description 实体类型
     *
     * This parameter is required.
     * @example OBJECTIVE
     *
     * @var string
     */
    public $entityType;

    /**
     * @description 字段ID
     *
     * This parameter is required.
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description 字段备注
     *
     * @example 字段备注
     *
     * @var string
     */
    public $note;

    /**
     * @description 字段数据来源
     *
     * This parameter is required.
     * @example OPEN
     *
     * @var string
     */
    public $source;

    /**
     * @description 字段元数据名称
     *
     * This parameter is required.
     * @example 字段名
     *
     * @var string
     */
    public $title;

    /**
     * @description 字段类型
     *
     * This parameter is required.
     * @example string
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'active'     => 'active',
        'alias'      => 'alias',
        'code'       => 'code',
        'entityType' => 'entityType',
        'fieldId'    => 'fieldId',
        'note'       => 'note',
        'source'     => 'source',
        'title'      => 'title',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->alias) {
            $res['alias'] = $this->alias;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalFieldMetaDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['alias'])) {
            $model->alias = $map['alias'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
