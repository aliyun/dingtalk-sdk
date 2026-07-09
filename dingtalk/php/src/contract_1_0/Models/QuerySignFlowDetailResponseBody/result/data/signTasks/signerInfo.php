<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signTasks;

use AlibabaCloud\Tea\Model;

class signerInfo extends Model
{
    /**
     * @var string
     */
    public $psnMobile;

    /**
     * @var string
     */
    public $psnName;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'psnMobile' => 'psnMobile',
        'psnName' => 'psnName',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->psnMobile) {
            $res['psnMobile'] = $this->psnMobile;
        }
        if (null !== $this->psnName) {
            $res['psnName'] = $this->psnName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signerInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['psnMobile'])) {
            $model->psnMobile = $map['psnMobile'];
        }
        if (isset($map['psnName'])) {
            $model->psnName = $map['psnName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
