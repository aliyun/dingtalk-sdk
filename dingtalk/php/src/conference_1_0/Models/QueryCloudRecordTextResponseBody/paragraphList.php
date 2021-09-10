<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponseBody\paragraphList\sentenceList;
use AlibabaCloud\Tea\Model;

class paragraphList extends Model
{
    /**
     * @description 游标，下次查询时使用
     *
     * @var int
     */
    public $token;

    /**
     * @description 状态，暂不解析
     *
     * @var int
     */
    public $status;

    /**
     * @description 发言人unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 发言人昵称
     *
     * @var string
     */
    public $nickName;

    /**
     * @description 云录制id
     *
     * @var int
     */
    public $recordId;

    /**
     * @description 开始时间，毫秒
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 结束时间，毫秒
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 段落内容
     *
     * @var string
     */
    public $paragraph;

    /**
     * @description 句子列表
     *
     * @var sentenceList[]
     */
    public $sentenceList;
    protected $_name = [
        'token'        => 'token',
        'status'       => 'status',
        'unionId'      => 'unionId',
        'nickName'     => 'nickName',
        'recordId'     => 'recordId',
        'startTime'    => 'startTime',
        'endTime'      => 'endTime',
        'paragraph'    => 'paragraph',
        'sentenceList' => 'sentenceList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->paragraph) {
            $res['paragraph'] = $this->paragraph;
        }
        if (null !== $this->sentenceList) {
            $res['sentenceList'] = [];
            if (null !== $this->sentenceList && \is_array($this->sentenceList)) {
                $n = 0;
                foreach ($this->sentenceList as $item) {
                    $res['sentenceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return paragraphList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['paragraph'])) {
            $model->paragraph = $map['paragraph'];
        }
        if (isset($map['sentenceList'])) {
            if (!empty($map['sentenceList'])) {
                $model->sentenceList = [];
                $n                   = 0;
                foreach ($map['sentenceList'] as $item) {
                    $model->sentenceList[$n++] = null !== $item ? sentenceList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
