<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersResponseBody;

use AlibabaCloud\Tea\Model;

class activeUserInfos extends Model
{
    /**
     * @description 最近二周的行为指数
     *
     * @var float
     */
    public $actionIndexL14d;

    /**
     * @description 最近一个月的行为指数
     *
     * @var float
     */
    public $actionIndexL30d;

    /**
     * @description 最近一周的行为指数
     *
     * @var float
     */
    public $actionIndexL7d;

    /**
     * @description 活跃度
     *
     * @var float
     */
    public $activeScore;

    /**
     * @description 昵称
     *
     * @var string
     */
    public $nickName;

    /**
     * @description 排名
     *
     * @var int
     */
    public $ranking;

    /**
     * @description 钉钉用户unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'actionIndexL14d' => 'actionIndexL14d',
        'actionIndexL30d' => 'actionIndexL30d',
        'actionIndexL7d'  => 'actionIndexL7d',
        'activeScore'     => 'activeScore',
        'nickName'        => 'nickName',
        'ranking'         => 'ranking',
        'unionId'         => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionIndexL14d) {
            $res['actionIndexL14d'] = $this->actionIndexL14d;
        }
        if (null !== $this->actionIndexL30d) {
            $res['actionIndexL30d'] = $this->actionIndexL30d;
        }
        if (null !== $this->actionIndexL7d) {
            $res['actionIndexL7d'] = $this->actionIndexL7d;
        }
        if (null !== $this->activeScore) {
            $res['activeScore'] = $this->activeScore;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->ranking) {
            $res['ranking'] = $this->ranking;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return activeUserInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionIndexL14d'])) {
            $model->actionIndexL14d = $map['actionIndexL14d'];
        }
        if (isset($map['actionIndexL30d'])) {
            $model->actionIndexL30d = $map['actionIndexL30d'];
        }
        if (isset($map['actionIndexL7d'])) {
            $model->actionIndexL7d = $map['actionIndexL7d'];
        }
        if (isset($map['activeScore'])) {
            $model->activeScore = $map['activeScore'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['ranking'])) {
            $model->ranking = $map['ranking'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
