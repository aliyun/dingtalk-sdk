<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyWorkspaceRequest\param;
use AlibabaCloud\Tea\Model;

class CopyWorkspaceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var param
     */
    public $param;
    protected $_name = [
        'param' => 'param',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->param) {
            $res['param'] = null !== $this->param ? $this->param->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyWorkspaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['param'])) {
            $model->param = param::fromMap($map['param']);
        }

        return $model;
    }
}
