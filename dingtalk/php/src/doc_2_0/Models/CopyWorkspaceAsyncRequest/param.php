<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyWorkspaceAsyncRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @example 0
     *
     * @var string
     */
    public $originWorkspaceId;
    protected $_name = [
        'originWorkspaceId' => 'originWorkspaceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->originWorkspaceId) {
            $res['originWorkspaceId'] = $this->originWorkspaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['originWorkspaceId'])) {
            $model->originWorkspaceId = $map['originWorkspaceId'];
        }

        return $model;
    }
}
