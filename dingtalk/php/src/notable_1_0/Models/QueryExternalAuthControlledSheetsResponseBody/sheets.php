<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryExternalAuthControlledSheetsResponseBody;

use AlibabaCloud\Tea\Model;

class sheets extends Model
{
    /**
     * @var string
     */
    public $externalAuthType;

    /**
     * @var string
     */
    public $externalConfig;

    /**
     * @var string
     */
    public $markedBy;

    /**
     * @var int
     */
    public $markedTime;

    /**
     * @var string
     */
    public $sheetId;

    /**
     * @var string
     */
    public $sheetName;
    protected $_name = [
        'externalAuthType' => 'externalAuthType',
        'externalConfig' => 'externalConfig',
        'markedBy' => 'markedBy',
        'markedTime' => 'markedTime',
        'sheetId' => 'sheetId',
        'sheetName' => 'sheetName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->externalAuthType) {
            $res['externalAuthType'] = $this->externalAuthType;
        }
        if (null !== $this->externalConfig) {
            $res['externalConfig'] = $this->externalConfig;
        }
        if (null !== $this->markedBy) {
            $res['markedBy'] = $this->markedBy;
        }
        if (null !== $this->markedTime) {
            $res['markedTime'] = $this->markedTime;
        }
        if (null !== $this->sheetId) {
            $res['sheetId'] = $this->sheetId;
        }
        if (null !== $this->sheetName) {
            $res['sheetName'] = $this->sheetName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sheets
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['externalAuthType'])) {
            $model->externalAuthType = $map['externalAuthType'];
        }
        if (isset($map['externalConfig'])) {
            $model->externalConfig = $map['externalConfig'];
        }
        if (isset($map['markedBy'])) {
            $model->markedBy = $map['markedBy'];
        }
        if (isset($map['markedTime'])) {
            $model->markedTime = $map['markedTime'];
        }
        if (isset($map['sheetId'])) {
            $model->sheetId = $map['sheetId'];
        }
        if (isset($map['sheetName'])) {
            $model->sheetName = $map['sheetName'];
        }

        return $model;
    }
}
