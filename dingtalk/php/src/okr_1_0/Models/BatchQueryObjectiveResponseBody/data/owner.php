<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveResponseBody\data\owner\department;
use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class owner extends Model
{
    /**
     * @var Stream
     */
    public $avatarMediaId;

    /**
     * @var Stream
     */
    public $corpId;

    /**
     * @var department
     */
    public $department;

    /**
     * @var Stream
     */
    public $id;

    /**
     * @var Stream
     */
    public $nickname;

    /**
     * @var Stream
     */
    public $staffId;
    protected $_name = [
        'avatarMediaId' => 'avatarMediaId',
        'corpId'        => 'corpId',
        'department'    => 'department',
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
        if (null !== $this->department) {
            $res['department'] = null !== $this->department ? $this->department->toMap() : null;
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
        if (isset($map['department'])) {
            $model->department = department::fromMap($map['department']);
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
