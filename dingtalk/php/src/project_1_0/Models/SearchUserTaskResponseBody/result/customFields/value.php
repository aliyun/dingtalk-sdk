<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskResponseBody\result\customFields;

use AlibabaCloud\Tea\Model;

class value extends Model
{
    /**
     * @example 642fb16c4a622b2e3184229c
     *
     * @var string
     */
    public $customFieldValueId;

    /**
     * @example 元数据内容
     *
     * @var string
     */
    public $metaString;

    /**
     * @example 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'customFieldValueId' => 'customFieldValueId',
        'metaString' => 'metaString',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customFieldValueId) {
            $res['customFieldValueId'] = $this->customFieldValueId;
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
        if (isset($map['customFieldValueId'])) {
            $model->customFieldValueId = $map['customFieldValueId'];
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
