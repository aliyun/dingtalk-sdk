<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetSpaceResponseBody;

use AlibabaCloud\Tea\Model;

class space extends Model
{
    /**
     * @example corp_id
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'corpId'       => 'corpId',
        'createTime'   => 'createTime',
        'modifiedTime' => 'modifiedTime',
        'spaceId'      => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return space
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
