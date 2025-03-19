<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreCardRecordResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreCardRecordResponseBody\content\detailList;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var string
     */
    public $conversationTitle;

    /**
     * @var detailList[]
     */
    public $detailList;

    /**
     * @var int
     */
    public $id;

    /**
     * @var int
     */
    public $memberNum;

    /**
     * @var int
     */
    public $readNum;

    /**
     * @var string
     */
    public $readPercent;

    /**
     * @var int
     */
    public $receiveNum;

    /**
     * @var string
     */
    public $sceneCardName;

    /**
     * @var string
     */
    public $sendStatus;

    /**
     * @var int
     */
    public $sendTime;
    protected $_name = [
        'conversationTitle' => 'conversationTitle',
        'detailList' => 'detailList',
        'id' => 'id',
        'memberNum' => 'memberNum',
        'readNum' => 'readNum',
        'readPercent' => 'readPercent',
        'receiveNum' => 'receiveNum',
        'sceneCardName' => 'sceneCardName',
        'sendStatus' => 'sendStatus',
        'sendTime' => 'sendTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationTitle) {
            $res['conversationTitle'] = $this->conversationTitle;
        }
        if (null !== $this->detailList) {
            $res['detailList'] = [];
            if (null !== $this->detailList && \is_array($this->detailList)) {
                $n = 0;
                foreach ($this->detailList as $item) {
                    $res['detailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->memberNum) {
            $res['memberNum'] = $this->memberNum;
        }
        if (null !== $this->readNum) {
            $res['readNum'] = $this->readNum;
        }
        if (null !== $this->readPercent) {
            $res['readPercent'] = $this->readPercent;
        }
        if (null !== $this->receiveNum) {
            $res['receiveNum'] = $this->receiveNum;
        }
        if (null !== $this->sceneCardName) {
            $res['sceneCardName'] = $this->sceneCardName;
        }
        if (null !== $this->sendStatus) {
            $res['sendStatus'] = $this->sendStatus;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationTitle'])) {
            $model->conversationTitle = $map['conversationTitle'];
        }
        if (isset($map['detailList'])) {
            if (!empty($map['detailList'])) {
                $model->detailList = [];
                $n = 0;
                foreach ($map['detailList'] as $item) {
                    $model->detailList[$n++] = null !== $item ? detailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['memberNum'])) {
            $model->memberNum = $map['memberNum'];
        }
        if (isset($map['readNum'])) {
            $model->readNum = $map['readNum'];
        }
        if (isset($map['readPercent'])) {
            $model->readPercent = $map['readPercent'];
        }
        if (isset($map['receiveNum'])) {
            $model->receiveNum = $map['receiveNum'];
        }
        if (isset($map['sceneCardName'])) {
            $model->sceneCardName = $map['sceneCardName'];
        }
        if (isset($map['sendStatus'])) {
            $model->sendStatus = $map['sendStatus'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }

        return $model;
    }
}
