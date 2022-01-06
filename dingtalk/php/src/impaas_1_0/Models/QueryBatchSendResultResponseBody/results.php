<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\QueryBatchSendResultResponseBody;

use AlibabaCloud\Tea\Model;

class results extends Model
{
    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string
     */
    public $appUid;

    /**
     * @var string
     */
    public $msgId;

    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMessage;
    protected $_name = [
        'conversationId' => 'conversationId',
        'appUid'         => 'appUid',
        'msgId'          => 'msgId',
        'errorCode'      => 'errorCode',
        'errorMessage'   => 'errorMessage',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
        }
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMessage) {
            $res['errorMessage'] = $this->errorMessage;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return results
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMessage'])) {
            $model->errorMessage = $map['errorMessage'];
        }

        return $model;
    }
}
