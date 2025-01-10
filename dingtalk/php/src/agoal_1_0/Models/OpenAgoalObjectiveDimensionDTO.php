<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalObjectiveDimensionDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var \AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenAgoalObjectiveDimensionDTO[]
     */
    public $children;

    /**
     * @description This parameter is required.
     *
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $dimensionId;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalFieldMetaDTO[]
     */
    public $fieldConfig;

    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $fieldValueMap;
    protected $_name = [
        'children'      => 'children',
        'dimensionId'   => 'dimensionId',
        'fieldConfig'   => 'fieldConfig',
        'fieldValueMap' => 'fieldValueMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->children) {
            $res['children'] = [];
            if (null !== $this->children && \is_array($this->children)) {
                $n = 0;
                foreach ($this->children as $item) {
                    $res['children'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dimensionId) {
            $res['dimensionId'] = $this->dimensionId;
        }
        if (null !== $this->fieldConfig) {
            $res['fieldConfig'] = [];
            if (null !== $this->fieldConfig && \is_array($this->fieldConfig)) {
                $n = 0;
                foreach ($this->fieldConfig as $item) {
                    $res['fieldConfig'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->fieldValueMap) {
            $res['fieldValueMap'] = $this->fieldValueMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalObjectiveDimensionDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n               = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? self::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dimensionId'])) {
            $model->dimensionId = $map['dimensionId'];
        }
        if (isset($map['fieldConfig'])) {
            if (!empty($map['fieldConfig'])) {
                $model->fieldConfig = [];
                $n                  = 0;
                foreach ($map['fieldConfig'] as $item) {
                    $model->fieldConfig[$n++] = null !== $item ? OpenAgoalFieldMetaDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['fieldValueMap'])) {
            $model->fieldValueMap = $map['fieldValueMap'];
        }

        return $model;
    }
}
