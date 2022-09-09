<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendByAppRequest extends Model
{
    /**
     * @description 文件id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @description 文件所在空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 目标用户id
     * 会通过应用发送消息给指定用户
     * @var string
     */
    public $targetUnionId;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryId'      => 'dentryId',
        'spaceId'       => 'spaceId',
        'targetUnionId' => 'targetUnionId',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->targetUnionId) {
            $res['targetUnionId'] = $this->targetUnionId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendByAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['targetUnionId'])) {
            $model->targetUnionId = $map['targetUnionId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
