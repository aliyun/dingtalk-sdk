<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncExceedApplyResponseBody extends Model
{
    /**
     * @description 是否同步成功
     *
     * @var bool
     */
    public $module;
    protected $_name = [
        'module' => 'module',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncExceedApplyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }

        return $model;
    }
}
