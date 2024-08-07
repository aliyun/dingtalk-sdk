<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoResponseBody\receiptFormTemplateInfoList\componentList;
use AlibabaCloud\Tea\Model;

class receiptFormTemplateInfoList extends Model
{
    /**
     * @var componentList[]
     */
    public $componentList;

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
        'componentList' => 'componentList',
        'name'          => 'name',
        'processCode'   => 'processCode',
        'status'        => 'status',
        'suiteId'       => 'suiteId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentList) {
            $res['componentList'] = [];
            if (null !== $this->componentList && \is_array($this->componentList)) {
                $n = 0;
                foreach ($this->componentList as $item) {
                    $res['componentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
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
        if (isset($map['componentList'])) {
            if (!empty($map['componentList'])) {
                $model->componentList = [];
                $n                    = 0;
                foreach ($map['componentList'] as $item) {
                    $model->componentList[$n++] = null !== $item ? componentList::fromMap($item) : $item;
                }
            }
        }
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
