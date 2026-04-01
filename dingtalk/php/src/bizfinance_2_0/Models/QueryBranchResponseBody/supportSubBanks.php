<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryBranchResponseBody;

use AlibabaCloud\Tea\Model;

class supportSubBanks extends Model
{
    /**
     * @var string
     */
    public $branchCode;

    /**
     * @var string
     */
    public $branchName;
    protected $_name = [
        'branchCode' => 'branchCode',
        'branchName' => 'branchName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->branchCode) {
            $res['branchCode'] = $this->branchCode;
        }
        if (null !== $this->branchName) {
            $res['branchName'] = $this->branchName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return supportSubBanks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['branchCode'])) {
            $model->branchCode = $map['branchCode'];
        }
        if (isset($map['branchName'])) {
            $model->branchName = $map['branchName'];
        }

        return $model;
    }
}
