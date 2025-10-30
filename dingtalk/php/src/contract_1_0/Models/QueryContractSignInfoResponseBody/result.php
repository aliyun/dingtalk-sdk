<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody\result\actualOriginator;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody\result\contractAttachmentFiles;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody\result\contractContentFiles;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody\result\oppositeParties;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody\result\ourParties;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractSignInfoResponseBody\result\signers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var actualOriginator
     */
    public $actualOriginator;

    /**
     * @var string
     */
    public $amountType;

    /**
     * @var int
     */
    public $applicantDate;

    /**
     * @var int
     */
    public $approveTime;

    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $contractAmount;

    /**
     * @var string
     */
    public $contractAmountMethod;

    /**
     * @var contractAttachmentFiles[]
     */
    public $contractAttachmentFiles;

    /**
     * @var contractContentFiles[]
     */
    public $contractContentFiles;

    /**
     * @var int
     */
    public $contractEndDate;

    /**
     * @var int
     */
    public $contractId;

    /**
     * @var string
     */
    public $contractName;

    /**
     * @var string
     */
    public $contractNo;

    /**
     * @var string
     */
    public $contractRemark;

    /**
     * @var int
     */
    public $contractStartDate;

    /**
     * @var string
     */
    public $contractStatus;

    /**
     * @var string
     */
    public $contractTermType;

    /**
     * @var string
     */
    public $currencyCode;

    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $directoryName;

    /**
     * @var string
     */
    public $effectiveStatus;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var oppositeParties[]
     */
    public $oppositeParties;

    /**
     * @var ourParties[]
     */
    public $ourParties;

    /**
     * @var string
     */
    public $ownerName;

    /**
     * @var string
     */
    public $ownerStaffId;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var signers[]
     */
    public $signers;
    protected $_name = [
        'actualOriginator' => 'actualOriginator',
        'amountType' => 'amountType',
        'applicantDate' => 'applicantDate',
        'approveTime' => 'approveTime',
        'bizId' => 'bizId',
        'contractAmount' => 'contractAmount',
        'contractAmountMethod' => 'contractAmountMethod',
        'contractAttachmentFiles' => 'contractAttachmentFiles',
        'contractContentFiles' => 'contractContentFiles',
        'contractEndDate' => 'contractEndDate',
        'contractId' => 'contractId',
        'contractName' => 'contractName',
        'contractNo' => 'contractNo',
        'contractRemark' => 'contractRemark',
        'contractStartDate' => 'contractStartDate',
        'contractStatus' => 'contractStatus',
        'contractTermType' => 'contractTermType',
        'currencyCode' => 'currencyCode',
        'deptName' => 'deptName',
        'directoryName' => 'directoryName',
        'effectiveStatus' => 'effectiveStatus',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'oppositeParties' => 'oppositeParties',
        'ourParties' => 'ourParties',
        'ownerName' => 'ownerName',
        'ownerStaffId' => 'ownerStaffId',
        'processInstanceId' => 'processInstanceId',
        'signers' => 'signers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualOriginator) {
            $res['actualOriginator'] = null !== $this->actualOriginator ? $this->actualOriginator->toMap() : null;
        }
        if (null !== $this->amountType) {
            $res['amountType'] = $this->amountType;
        }
        if (null !== $this->applicantDate) {
            $res['applicantDate'] = $this->applicantDate;
        }
        if (null !== $this->approveTime) {
            $res['approveTime'] = $this->approveTime;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->contractAmount) {
            $res['contractAmount'] = $this->contractAmount;
        }
        if (null !== $this->contractAmountMethod) {
            $res['contractAmountMethod'] = $this->contractAmountMethod;
        }
        if (null !== $this->contractAttachmentFiles) {
            $res['contractAttachmentFiles'] = [];
            if (null !== $this->contractAttachmentFiles && \is_array($this->contractAttachmentFiles)) {
                $n = 0;
                foreach ($this->contractAttachmentFiles as $item) {
                    $res['contractAttachmentFiles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->contractContentFiles) {
            $res['contractContentFiles'] = [];
            if (null !== $this->contractContentFiles && \is_array($this->contractContentFiles)) {
                $n = 0;
                foreach ($this->contractContentFiles as $item) {
                    $res['contractContentFiles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->contractEndDate) {
            $res['contractEndDate'] = $this->contractEndDate;
        }
        if (null !== $this->contractId) {
            $res['contractId'] = $this->contractId;
        }
        if (null !== $this->contractName) {
            $res['contractName'] = $this->contractName;
        }
        if (null !== $this->contractNo) {
            $res['contractNo'] = $this->contractNo;
        }
        if (null !== $this->contractRemark) {
            $res['contractRemark'] = $this->contractRemark;
        }
        if (null !== $this->contractStartDate) {
            $res['contractStartDate'] = $this->contractStartDate;
        }
        if (null !== $this->contractStatus) {
            $res['contractStatus'] = $this->contractStatus;
        }
        if (null !== $this->contractTermType) {
            $res['contractTermType'] = $this->contractTermType;
        }
        if (null !== $this->currencyCode) {
            $res['currencyCode'] = $this->currencyCode;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->directoryName) {
            $res['directoryName'] = $this->directoryName;
        }
        if (null !== $this->effectiveStatus) {
            $res['effectiveStatus'] = $this->effectiveStatus;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->oppositeParties) {
            $res['oppositeParties'] = [];
            if (null !== $this->oppositeParties && \is_array($this->oppositeParties)) {
                $n = 0;
                foreach ($this->oppositeParties as $item) {
                    $res['oppositeParties'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ourParties) {
            $res['ourParties'] = [];
            if (null !== $this->ourParties && \is_array($this->ourParties)) {
                $n = 0;
                foreach ($this->ourParties as $item) {
                    $res['ourParties'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ownerName) {
            $res['ownerName'] = $this->ownerName;
        }
        if (null !== $this->ownerStaffId) {
            $res['ownerStaffId'] = $this->ownerStaffId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->signers) {
            $res['signers'] = [];
            if (null !== $this->signers && \is_array($this->signers)) {
                $n = 0;
                foreach ($this->signers as $item) {
                    $res['signers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['actualOriginator'])) {
            $model->actualOriginator = actualOriginator::fromMap($map['actualOriginator']);
        }
        if (isset($map['amountType'])) {
            $model->amountType = $map['amountType'];
        }
        if (isset($map['applicantDate'])) {
            $model->applicantDate = $map['applicantDate'];
        }
        if (isset($map['approveTime'])) {
            $model->approveTime = $map['approveTime'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['contractAmount'])) {
            $model->contractAmount = $map['contractAmount'];
        }
        if (isset($map['contractAmountMethod'])) {
            $model->contractAmountMethod = $map['contractAmountMethod'];
        }
        if (isset($map['contractAttachmentFiles'])) {
            if (!empty($map['contractAttachmentFiles'])) {
                $model->contractAttachmentFiles = [];
                $n = 0;
                foreach ($map['contractAttachmentFiles'] as $item) {
                    $model->contractAttachmentFiles[$n++] = null !== $item ? contractAttachmentFiles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['contractContentFiles'])) {
            if (!empty($map['contractContentFiles'])) {
                $model->contractContentFiles = [];
                $n = 0;
                foreach ($map['contractContentFiles'] as $item) {
                    $model->contractContentFiles[$n++] = null !== $item ? contractContentFiles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['contractEndDate'])) {
            $model->contractEndDate = $map['contractEndDate'];
        }
        if (isset($map['contractId'])) {
            $model->contractId = $map['contractId'];
        }
        if (isset($map['contractName'])) {
            $model->contractName = $map['contractName'];
        }
        if (isset($map['contractNo'])) {
            $model->contractNo = $map['contractNo'];
        }
        if (isset($map['contractRemark'])) {
            $model->contractRemark = $map['contractRemark'];
        }
        if (isset($map['contractStartDate'])) {
            $model->contractStartDate = $map['contractStartDate'];
        }
        if (isset($map['contractStatus'])) {
            $model->contractStatus = $map['contractStatus'];
        }
        if (isset($map['contractTermType'])) {
            $model->contractTermType = $map['contractTermType'];
        }
        if (isset($map['currencyCode'])) {
            $model->currencyCode = $map['currencyCode'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['directoryName'])) {
            $model->directoryName = $map['directoryName'];
        }
        if (isset($map['effectiveStatus'])) {
            $model->effectiveStatus = $map['effectiveStatus'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['oppositeParties'])) {
            if (!empty($map['oppositeParties'])) {
                $model->oppositeParties = [];
                $n = 0;
                foreach ($map['oppositeParties'] as $item) {
                    $model->oppositeParties[$n++] = null !== $item ? oppositeParties::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ourParties'])) {
            if (!empty($map['ourParties'])) {
                $model->ourParties = [];
                $n = 0;
                foreach ($map['ourParties'] as $item) {
                    $model->ourParties[$n++] = null !== $item ? ourParties::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ownerName'])) {
            $model->ownerName = $map['ownerName'];
        }
        if (isset($map['ownerStaffId'])) {
            $model->ownerStaffId = $map['ownerStaffId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['signers'])) {
            if (!empty($map['signers'])) {
                $model->signers = [];
                $n = 0;
                foreach ($map['signers'] as $item) {
                    $model->signers[$n++] = null !== $item ? signers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
