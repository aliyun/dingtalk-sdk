<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryResponseBody;

use AlibabaCloud\Tea\Model;

class messageReadInfoList extends Model
{
    /**
     * @example 曲大岳
     *
     * @var string
     */
    public $name;

    /**
     * @example READ
     *
     * @var string
     */
    public $readStatus;

    /**
     * @example 1433138400000
     *
     * @var int
     */
    public $readTimestamp;

    /**
     * @example 201382020
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'          => 'name',
        'readStatus'    => 'readStatus',
        'readTimestamp' => 'readTimestamp',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->readStatus) {
            $res['readStatus'] = $this->readStatus;
        }
        if (null !== $this->readTimestamp) {
            $res['readTimestamp'] = $this->readTimestamp;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messageReadInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['readStatus'])) {
            $model->readStatus = $map['readStatus'];
        }
        if (isset($map['readTimestamp'])) {
            $model->readTimestamp = $map['readTimestamp'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
