<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpacesInfoRequest extends Model
{
    /**
     * @var int[]
     */
    public $referIds;

    /**
     * @var string
     */
    public $residentCorpId;
    protected $_name = [
        'referIds'       => 'referIds',
        'residentCorpId' => 'residentCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->referIds) {
            $res['referIds'] = $this->referIds;
        }
        if (null !== $this->residentCorpId) {
            $res['residentCorpId'] = $this->residentCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSpacesInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['referIds'])) {
            if (!empty($map['referIds'])) {
                $model->referIds = $map['referIds'];
            }
        }
        if (isset($map['residentCorpId'])) {
            $model->residentCorpId = $map['residentCorpId'];
        }

        return $model;
    }
}
