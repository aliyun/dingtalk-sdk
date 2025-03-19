<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeByUrlResponseBody\node;
use AlibabaCloud\Tea\Model;

class GetNodeByUrlResponseBody extends Model
{
    /**
     * @var node
     */
    public $node;
    protected $_name = [
        'node' => 'node',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->node) {
            $res['node'] = null !== $this->node ? $this->node->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetNodeByUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['node'])) {
            $model->node = node::fromMap($map['node']);
        }

        return $model;
    }
}
