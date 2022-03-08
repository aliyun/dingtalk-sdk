<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDetailResponseBody;

use AlibabaCloud\Tea\Model;

class logs extends Model
{
    /**
     * @var string
     */
    public $logType;

    /**
     * @var string
     */
    public $operateDescription;

    /**
     * @var float
     */
    public $operateTime;

    /**
     * @var string
     */
    public $operatorAccountName;
    protected $_name = [
        'logType'             => 'logType',
        'operateDescription'  => 'operateDescription',
        'operateTime'         => 'operateTime',
        'operatorAccountName' => 'operatorAccountName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->logType) {
            $res['logType'] = $this->logType;
        }
        if (null !== $this->operateDescription) {
            $res['operateDescription'] = $this->operateDescription;
        }
        if (null !== $this->operateTime) {
            $res['operateTime'] = $this->operateTime;
        }
        if (null !== $this->operatorAccountName) {
            $res['operatorAccountName'] = $this->operatorAccountName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return logs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['logType'])) {
            $model->logType = $map['logType'];
        }
        if (isset($map['operateDescription'])) {
            $model->operateDescription = $map['operateDescription'];
        }
        if (isset($map['operateTime'])) {
            $model->operateTime = $map['operateTime'];
        }
        if (isset($map['operatorAccountName'])) {
            $model->operatorAccountName = $map['operatorAccountName'];
        }

        return $model;
    }
}
