<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data;

use AlibabaCloud\Tea\Model;

class relatedDoc extends Model
{
    /**
     * @var string
     */
    public $link;

    /**
     * @description 文档名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 文档类型，分别为adoc或者asheet
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'link' => 'link',
        'name' => 'name',
        'type' => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relatedDoc
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
