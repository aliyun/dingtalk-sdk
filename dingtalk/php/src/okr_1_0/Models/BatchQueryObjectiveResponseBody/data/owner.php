<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveResponseBody\data;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class owner extends Model
{
    /**
     * @example @lADPDh0cQ_j4Mi_NBULNBUA
     *
     * @var Stream
     */
    public $avatarMediaId;

    /**
     * @example ding4d1c8883ff63ee8124f2f5cc6abecb85
     *
     * @var Stream
     */
    public $corpId;

    /**
     * @example K1AMgq
     *
     * @var Stream
     */
    public $id;

    /**
     * @example 你好
     *
     * @var Stream
     */
    public $nickname;

    /**
     * @example 06186238011033616
     *
     * @var Stream
     */
    public $userId;
    protected $_name = [
        'avatarMediaId' => 'avatarMediaId',
        'corpId' => 'corpId',
        'id' => 'id',
        'nickname' => 'nickname',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarMediaId) {
            $res['avatarMediaId'] = $this->avatarMediaId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->nickname) {
            $res['nickname'] = $this->nickname;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return owner
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarMediaId'])) {
            $model->avatarMediaId = $map['avatarMediaId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['nickname'])) {
            $model->nickname = $map['nickname'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
