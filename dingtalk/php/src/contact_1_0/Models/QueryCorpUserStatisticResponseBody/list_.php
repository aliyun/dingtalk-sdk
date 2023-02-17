<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpUserStatisticResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 用户头像
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 收下数
     *
     * @var int
     */
    public $receiveCnt;

    /**
     * @description 发送数
     *
     * @var int
     */
    public $sendCnt;

    /**
     * @description 用户id
     *
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'avatarUrl'  => 'avatarUrl',
        'name'       => 'name',
        'receiveCnt' => 'receiveCnt',
        'sendCnt'    => 'sendCnt',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->receiveCnt) {
            $res['receiveCnt'] = $this->receiveCnt;
        }
        if (null !== $this->sendCnt) {
            $res['sendCnt'] = $this->sendCnt;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['receiveCnt'])) {
            $model->receiveCnt = $map['receiveCnt'];
        }
        if (isset($map['sendCnt'])) {
            $model->sendCnt = $map['sendCnt'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
