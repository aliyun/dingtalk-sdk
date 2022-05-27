<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMiniAppMetaDataResponseBody\result;
use AlibabaCloud\Tea\Model;

class GetMiniAppMetaDataResponseBody extends Model
{
    /**
     * @description receiveTime
     *
     * @var int
     */
    public $dingOpenErrcode;

    /**
     * @description errorMsg
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @description result
     *
     * @var result
     */
    public $result;

    /**
     * @description requestId
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'dingOpenErrcode' => 'dingOpenErrcode',
        'errorMsg'        => 'errorMsg',
        'result'          => 'result',
        'success'         => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOpenErrcode) {
            $res['dingOpenErrcode'] = $this->dingOpenErrcode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMiniAppMetaDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingOpenErrcode'])) {
            $model->dingOpenErrcode = $map['dingOpenErrcode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
