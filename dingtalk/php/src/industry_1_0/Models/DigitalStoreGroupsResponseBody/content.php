<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 分组Id
     *
     * @var int
     */
    public $groupId;

    /**
     * @description 分组名称
     *
     * @var string
     */
    public $groupName;
    protected $_name = [
        'groupId'   => 'groupId',
        'groupName' => 'groupName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }

        return $model;
    }
}
