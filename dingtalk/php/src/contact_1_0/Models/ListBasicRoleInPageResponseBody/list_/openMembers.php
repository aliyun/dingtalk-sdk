<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_;

use AlibabaCloud\Tea\Model;

class openMembers extends Model
{
    /**
     * @var string
     */
    public $belongCorpId;

    /**
     * @var string
     */
    public $memberId;

    /**
     * @var string
     */
    public $memberType;

    /**
     * @var string
     */
    public $operateUserId;
    protected $_name = [
        'belongCorpId'  => 'belongCorpId',
        'memberId'      => 'memberId',
        'memberType'    => 'memberType',
        'operateUserId' => 'operateUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->belongCorpId) {
            $res['belongCorpId'] = $this->belongCorpId;
        }
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openMembers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['belongCorpId'])) {
            $model->belongCorpId = $map['belongCorpId'];
        }
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }

        return $model;
    }
}
