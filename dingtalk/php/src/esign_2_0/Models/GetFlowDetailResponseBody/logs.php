<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDetailResponseBody;

use AlibabaCloud\Tea\Model;

class logs extends Model
{
    /**
     * @var string
     */
    public $operatorAccountName;

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
    protected $_name = [
        'operatorAccountName' => 'operatorAccountName',
        'logType'             => 'logType',
        'operateDescription'  => 'operateDescription',
        'operateTime'         => 'operateTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorAccountName) {
            $res['operatorAccountName'] = $this->operatorAccountName;
        }
        if (null !== $this->logType) {
            $res['logType'] = $this->logType;
        }
        if (null !== $this->operateDescription) {
            $res['operateDescription'] = $this->operateDescription;
        }
        if (null !== $this->operateTime) {
            $res['operateTime'] = $this->operateTime;
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
        if (isset($map['operatorAccountName'])) {
            $model->operatorAccountName = $map['operatorAccountName'];
        }
        if (isset($map['logType'])) {
            $model->logType = $map['logType'];
        }
        if (isset($map['operateDescription'])) {
            $model->operateDescription = $map['operateDescription'];
        }
        if (isset($map['operateTime'])) {
            $model->operateTime = $map['operateTime'];
        }

        return $model;
    }
}
