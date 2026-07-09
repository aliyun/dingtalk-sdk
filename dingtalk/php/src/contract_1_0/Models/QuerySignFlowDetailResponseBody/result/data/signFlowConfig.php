<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class signFlowConfig extends Model
{
    /**
     * @var bool
     */
    public $autoStart;

    /**
     * @var bool
     */
    public $isOrderedSign;

    /**
     * @var string
     */
    public $signFlowName;
    protected $_name = [
        'autoStart' => 'autoStart',
        'isOrderedSign' => 'isOrderedSign',
        'signFlowName' => 'signFlowName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoStart) {
            $res['autoStart'] = $this->autoStart;
        }
        if (null !== $this->isOrderedSign) {
            $res['isOrderedSign'] = $this->isOrderedSign;
        }
        if (null !== $this->signFlowName) {
            $res['signFlowName'] = $this->signFlowName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signFlowConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoStart'])) {
            $model->autoStart = $map['autoStart'];
        }
        if (isset($map['isOrderedSign'])) {
            $model->isOrderedSign = $map['isOrderedSign'];
        }
        if (isset($map['signFlowName'])) {
            $model->signFlowName = $map['signFlowName'];
        }

        return $model;
    }
}
