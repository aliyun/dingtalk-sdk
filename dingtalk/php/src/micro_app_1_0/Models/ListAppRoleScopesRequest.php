<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAppRoleScopesRequest extends Model
{
    /**
     * @description 起始点，默认0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 数据量，默认20，最大50
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'nextToken' => 'nextToken',
        'size'      => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAppRoleScopesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
