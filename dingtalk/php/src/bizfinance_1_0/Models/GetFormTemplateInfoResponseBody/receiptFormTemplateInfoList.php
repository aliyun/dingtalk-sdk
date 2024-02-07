<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoResponseBody;

use AlibabaCloud\Tea\Model;

class receiptFormTemplateInfoList extends Model
{
    /**
     * @example "报销套件"
     *
     * @var string
     */
    public $name;

    /**
     * @example "PROC-EB81447A-B0E3-4A2F-A719-0A85EFD09184"
     *
     * @var string
     */
    public $processCode;

    /**
     * @example "invalid"
     *
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $suiteId;
    protected $_name = [
        'name'        => 'name',
        'processCode' => 'processCode',
        'status'      => 'status',
        'suiteId'     => 'suiteId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receiptFormTemplateInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }

        return $model;
    }
}
