<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRoleMembersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding4lj234j3hj43hl312lh
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $memberUserIdListInTrunkOrg;
    protected $_name = [
        'corpId'                     => 'corpId',
        'memberUserIdListInTrunkOrg' => 'memberUserIdListInTrunkOrg',
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
        if (null !== $this->memberUserIdListInTrunkOrg) {
            $res['memberUserIdListInTrunkOrg'] = $this->memberUserIdListInTrunkOrg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['memberUserIdListInTrunkOrg'])) {
            if (!empty($map['memberUserIdListInTrunkOrg'])) {
                $model->memberUserIdListInTrunkOrg = $map['memberUserIdListInTrunkOrg'];
            }
        }

        return $model;
    }
}
