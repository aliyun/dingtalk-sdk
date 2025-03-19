<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $readUserIdList;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'readUserIdList' => 'readUserIdList',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->readUserIdList) {
            $res['readUserIdList'] = $this->readUserIdList;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['readUserIdList'])) {
            if (!empty($map['readUserIdList'])) {
                $model->readUserIdList = $map['readUserIdList'];
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
