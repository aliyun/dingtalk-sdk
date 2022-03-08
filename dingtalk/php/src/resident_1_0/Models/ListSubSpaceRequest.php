<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSubSpaceRequest extends Model
{
    /**
     * @var int
     */
    public $referId;

    /**
     * @description A short description of struct
     *
     * @var string
     */
    public $residentCorpId;
    protected $_name = [
        'referId'        => 'referId',
        'residentCorpId' => 'residentCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->referId) {
            $res['referId'] = $this->referId;
        }
        if (null !== $this->residentCorpId) {
            $res['residentCorpId'] = $this->residentCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['referId'])) {
            $model->referId = $map['referId'];
        }
        if (isset($map['residentCorpId'])) {
            $model->residentCorpId = $map['residentCorpId'];
        }

        return $model;
    }
}
