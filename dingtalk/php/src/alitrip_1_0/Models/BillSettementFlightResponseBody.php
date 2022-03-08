<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementFlightResponseBody\module;
use AlibabaCloud\Tea\Model;

class BillSettementFlightResponseBody extends Model
{
    /**
     * @description module
     *
     * @var module
     */
    public $module;

    /**
     * @description 结果code
     *
     * @var int
     */
    public $resultCode;

    /**
     * @description 结果msg
     *
     * @var string
     */
    public $resultMsg;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'module'     => 'module',
        'resultCode' => 'resultCode',
        'resultMsg'  => 'resultMsg',
        'success'    => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->module) {
            $res['module'] = null !== $this->module ? $this->module->toMap() : null;
        }
        if (null !== $this->resultCode) {
            $res['resultCode'] = $this->resultCode;
        }
        if (null !== $this->resultMsg) {
            $res['resultMsg'] = $this->resultMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BillSettementFlightResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['module'])) {
            $model->module = module::fromMap($map['module']);
        }
        if (isset($map['resultCode'])) {
            $model->resultCode = $map['resultCode'];
        }
        if (isset($map['resultMsg'])) {
            $model->resultMsg = $map['resultMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
