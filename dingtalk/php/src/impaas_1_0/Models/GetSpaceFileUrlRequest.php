<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpaceFileUrlRequest extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $fileId;

    /**
     * @example 123#123@dingding
     *
     * @var string
     */
    public $senderUid;

    /**
     * @example 123
     *
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'fileId'    => 'fileId',
        'senderUid' => 'senderUid',
        'spaceId'   => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->senderUid) {
            $res['senderUid'] = $this->senderUid;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSpaceFileUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['senderUid'])) {
            $model->senderUid = $map['senderUid'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
