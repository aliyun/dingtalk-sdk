<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class CleanFileRequest extends Model
{
    /**
     * @var string
     */
    public $cleanReason;

    /**
     * @var int
     */
    public $dentryId;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'cleanReason' => 'cleanReason',
        'dentryId' => 'dentryId',
        'operatorId' => 'operatorId',
        'spaceId' => 'spaceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cleanReason) {
            $res['cleanReason'] = $this->cleanReason;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CleanFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cleanReason'])) {
            $model->cleanReason = $map['cleanReason'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
