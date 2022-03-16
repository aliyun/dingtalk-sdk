<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class owner extends Model
{
    /**
     * @description 所属者头像。 ID
     *
     * @var Stream
     */
    public $avatarMediaId;

    /**
     * @description 所属者组织 I。D
     *
     * @var Stream
     */
    public $corpId;

    /**
     * @description 所属者 ID。
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
    public $staffId;
    protected $_name = [
        'avatarMediaId' => 'avatarMediaId',
        'corpId'        => 'corpId',
        'id'            => 'id',
        'nickname'      => 'nickname',
        'staffId'       => 'staffId',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->nickname) {
            $res['nickname'] = $this->nickname;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
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
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
