<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryUserResponseBody;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class data extends Model
{
    /**
     * @description 所属者头像。 ID
     *
     * @var Stream
     */
    public $avatarMediaId;

    /**
     * @description 所属者头像。 URL
     *
     * @var Stream
     */
    public $avatarUrl;

    /**
     * @description 所属者组织 I。D
     *
     * @var Stream
     */
    public $corpId;

    /**
     * @description 所属者在 OKR 系统中的 ID。
     *
     * @var Stream
     */
    public $id;

    /**
     * @description 所属者昵称。
     *
     * @var Stream
     */
    public $nickname;

    /**
     * @description 所属者 userId。
     *
     * @var Stream
     */
    public $userId;
    protected $_name = [
        'avatarMediaId' => 'avatarMediaId',
        'avatarUrl'     => 'avatarUrl',
        'corpId'        => 'corpId',
        'id'            => 'id',
        'nickname'      => 'nickname',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarMediaId) {
            $res['avatarMediaId'] = $this->avatarMediaId;
        }
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
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
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarMediaId'])) {
            $model->avatarMediaId = $map['avatarMediaId'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
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
