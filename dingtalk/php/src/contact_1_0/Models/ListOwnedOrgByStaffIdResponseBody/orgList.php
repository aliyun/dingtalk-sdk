<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListOwnedOrgByStaffIdResponseBody;

use AlibabaCloud\Tea\Model;

class orgList extends Model
{
    /**
     * @description corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description corpName
     *
     * @var string
     */
    public $corpName;
    protected $_name = [
        'corpId'   => 'corpId',
        'corpName' => 'corpName',
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
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }

        return $model;
    }
}
