<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpUserStatisticResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example wwww.xxxxx.com/xxx.jpg
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example 5
     *
     * @var int
     */
    public $receiveCnt;

    /**
     * @example 3
     *
     * @var int
     */
    public $sendCnt;

    /**
     * @example RCsp7PJmmTUr7w0hbs9aKAiEiE
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
