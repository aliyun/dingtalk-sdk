<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileDownloadUrlRequest extends Model
{
    /**
     * @var string
     */
    public $bizFlowId;

    /**
     * @var string
     */
    public $fileId;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $signFlowId;
    protected $_name = [
        'bizFlowId' => 'bizFlowId',
        'fileId' => 'fileId',
        'requestId' => 'requestId',
        'signFlowId' => 'signFlowId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizFlowId) {
            $res['bizFlowId'] = $this->bizFlowId;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->signFlowId) {
            $res['signFlowId'] = $this->signFlowId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileDownloadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizFlowId'])) {
            $model->bizFlowId = $map['bizFlowId'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['signFlowId'])) {
            $model->signFlowId = $map['signFlowId'];
        }

        return $model;
    }
}
