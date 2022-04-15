<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest;

use AlibabaCloud\Tea\Model;

class location extends Model
{
    /**
     * @description 头部插入
     *
     * @var bool
     */
    public $head;
    protected $_name = [
        'head' => 'head',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->head) {
            $res['head'] = $this->head;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return location
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['head'])) {
            $model->head = $map['head'];
        }

        return $model;
    }
}
