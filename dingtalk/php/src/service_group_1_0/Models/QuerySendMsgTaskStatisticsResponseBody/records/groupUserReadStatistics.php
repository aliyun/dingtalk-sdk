<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsResponseBody\records;

use AlibabaCloud\Tea\Model;

class groupUserReadStatistics extends Model
{
    /**
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var int
     */
    public $readUserInc;

    /**
     * @var int
     */
    public $sendUserInc;

    /**
     * @var int
     */
    public $unReadUserInc;
    protected $_name = [
        'openBatchTaskId'    => 'openBatchTaskId',
        'openConversationId' => 'openConversationId',
        'readUserInc'        => 'readUserInc',
        'sendUserInc'        => 'sendUserInc',
        'unReadUserInc'      => 'unReadUserInc',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->readUserInc) {
            $res['readUserInc'] = $this->readUserInc;
        }
        if (null !== $this->sendUserInc) {
            $res['sendUserInc'] = $this->sendUserInc;
        }
        if (null !== $this->unReadUserInc) {
            $res['unReadUserInc'] = $this->unReadUserInc;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupUserReadStatistics
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['readUserInc'])) {
            $model->readUserInc = $map['readUserInc'];
        }
        if (isset($map['sendUserInc'])) {
            $model->sendUserInc = $map['sendUserInc'];
        }
        if (isset($map['unReadUserInc'])) {
            $model->unReadUserInc = $map['unReadUserInc'];
        }

        return $model;
    }
}
