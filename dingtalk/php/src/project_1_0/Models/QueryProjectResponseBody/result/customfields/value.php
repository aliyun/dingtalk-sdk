<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectResponseBody\result\customfields;

use AlibabaCloud\Tea\Model;

class value extends Model
{
    /**
     * @example 64ba333e4206372f3f5cxxxx
     *
     * @var string
     */
    public $fieldvalueId;

    /**
     * @example 3
     *
     * @var string
     */
    public $metaString;

    /**
     * @example 自定义字段1
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'fieldvalueId' => 'fieldvalueId',
        'metaString'   => 'metaString',
        'title'        => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldvalueId) {
            $res['fieldvalueId'] = $this->fieldvalueId;
        }
        if (null !== $this->metaString) {
            $res['metaString'] = $this->metaString;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return value
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldvalueId'])) {
            $model->fieldvalueId = $map['fieldvalueId'];
        }
        if (isset($map['metaString'])) {
            $model->metaString = $map['metaString'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
