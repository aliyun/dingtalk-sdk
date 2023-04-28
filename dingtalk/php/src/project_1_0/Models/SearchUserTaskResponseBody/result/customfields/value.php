<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskResponseBody\result\customfields;

use AlibabaCloud\Tea\Model;

class value extends Model
{
    /**
     * @var string
     */
    public $fieldvalueId;

    /**
     * @var string
     */
    public $metaString;

    /**
     * @var string
     */
    public $title;

    /**
     * @example 35
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'fieldvalueId' => 'fieldvalueId',
        'metaString'   => 'metaString',
        'title'        => 'title',
        'totalCount'   => 'totalCount',
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
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
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
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
