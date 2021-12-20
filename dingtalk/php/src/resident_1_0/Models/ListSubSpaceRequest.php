<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSubSpaceRequest extends Model
{
    /**
     * @description A short description of struct
     *
     * @var string
     */
    public $residentCorpId;

    /**
     * @var int
     */
    public $referId;
    protected $_name = [
        'residentCorpId' => 'residentCorpId',
        'referId'        => 'referId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->residentCorpId) {
            $res['residentCorpId'] = $this->residentCorpId;
        }
        if (null !== $this->referId) {
            $res['referId'] = $this->referId;
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
        if (isset($map['residentCorpId'])) {
            $model->residentCorpId = $map['residentCorpId'];
        }
        if (isset($map['referId'])) {
            $model->referId = $map['referId'];
        }

        return $model;
    }
}
