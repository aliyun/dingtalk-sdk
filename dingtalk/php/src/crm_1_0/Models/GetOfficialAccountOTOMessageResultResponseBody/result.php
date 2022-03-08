<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 已读消息的userid列表
     *
     * @var string[]
     */
    public $readUserIdList;

    /**
     * @description 执行状态： 0：未开始  1：处理中  2：处理完毕
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'readUserIdList' => 'readUserIdList',
        'status'         => 'status',
    ];

    public function validate()
    {
    }

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
