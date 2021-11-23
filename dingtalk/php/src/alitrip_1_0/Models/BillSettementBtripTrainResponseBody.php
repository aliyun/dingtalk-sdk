<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementBtripTrainResponseBody\module;
use AlibabaCloud\Tea\Model;

class BillSettementBtripTrainResponseBody extends Model
{
    /**
     * @description 结果msg
     *
     * @var string
     */
    public $resultMsg;

    /**
     * @description module
     *
     * @var module
     */
    public $module;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 结果code
     *
     * @var int
     */
    public $resultCode;
    protected $_name = [
        'resultMsg'  => 'resultMsg',
        'module'     => 'module',
        'success'    => 'success',
        'resultCode' => 'resultCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resultMsg) {
            $res['resultMsg'] = $this->resultMsg;
        }
        if (null !== $this->module) {
            $res['module'] = null !== $this->module ? $this->module->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->resultCode) {
            $res['resultCode'] = $this->resultCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BillSettementBtripTrainResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resultMsg'])) {
            $model->resultMsg = $map['resultMsg'];
        }
        if (isset($map['module'])) {
            $model->module = module::fromMap($map['module']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['resultCode'])) {
            $model->resultCode = $map['resultCode'];
        }

        return $model;
    }
}
