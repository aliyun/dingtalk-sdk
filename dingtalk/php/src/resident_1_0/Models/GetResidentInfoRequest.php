<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetResidentInfoRequest extends Model
{
    /**
     * @var string
     */
    public $residentCorpId;
    protected $_name = [
        'residentCorpId' => 'residentCorpId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResidentInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['residentCorpId'])) {
            $model->residentCorpId = $map['residentCorpId'];
        }

        return $model;
    }
}
