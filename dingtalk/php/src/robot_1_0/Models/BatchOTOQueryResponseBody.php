<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryResponseBody\messageReadInfoList;
use AlibabaCloud\Tea\Model;

class BatchOTOQueryResponseBody extends Model
{
    /**
     * @var messageReadInfoList[]
     */
    public $messageReadInfoList;

    /**
     * @example SUCESS
     *
     * @var string
     */
    public $sendStatus;
    protected $_name = [
        'messageReadInfoList' => 'messageReadInfoList',
        'sendStatus' => 'sendStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageReadInfoList) {
            $res['messageReadInfoList'] = [];
            if (null !== $this->messageReadInfoList && \is_array($this->messageReadInfoList)) {
                $n = 0;
                foreach ($this->messageReadInfoList as $item) {
                    $res['messageReadInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sendStatus) {
            $res['sendStatus'] = $this->sendStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchOTOQueryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageReadInfoList'])) {
            if (!empty($map['messageReadInfoList'])) {
                $model->messageReadInfoList = [];
                $n = 0;
                foreach ($map['messageReadInfoList'] as $item) {
                    $model->messageReadInfoList[$n++] = null !== $item ? messageReadInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sendStatus'])) {
            $model->sendStatus = $map['sendStatus'];
        }

        return $model;
    }
}
