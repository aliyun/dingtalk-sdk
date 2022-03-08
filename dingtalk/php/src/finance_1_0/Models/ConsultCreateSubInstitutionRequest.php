<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\contactInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\legalPersonCertInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\qualificationInfos;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\settleInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstAddressInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstAuthInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstBasicInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstCertifyInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstInvoiceInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstShopInfo;
use AlibabaCloud\Tea\Model;

class ConsultCreateSubInstitutionRequest extends Model
{
    /**
     * @description 签约支付宝账户，用于协议确认
     *
     * @var string
     */
    public $bindingAlipayLogonId;

    /**
     * @description 联系人
     *
     * @var contactInfo
     */
    public $contactInfo;

    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @var legalPersonCertInfo
     */
    public $legalPersonCertInfo;

    /**
     * @description 进件创建外部流水号
     *
     * @var string
     */
    public $outTradeNo;

    /**
     * @description 进件渠道
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description 资质信息
     *
     * @var qualificationInfos[]
     */
    public $qualificationInfos;

    /**
     * @description 开通的服务类型
     *
     * @var string[]
     */
    public $services;

    /**
     * @description 资金账户信息
     *
     * @var settleInfo
     */
    public $settleInfo;

    /**
     * @description 解决方案，包含清算、费率规则
     *
     * @var string
     */
    public $solution;

    /**
     * @description 子机构地址信息
     *
     * @var subInstAddressInfo
     */
    public $subInstAddressInfo;

    /**
     * @description 授权信息
     *
     * @var subInstAuthInfo
     */
    public $subInstAuthInfo;

    /**
     * @description 子机构基本信息
     *
     * @var subInstBasicInfo
     */
    public $subInstBasicInfo;

    /**
     * @description 子机构认证信息
     *
     * @var subInstCertifyInfo
     */
    public $subInstCertifyInfo;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 开票信息
     *
     * @var subInstInvoiceInfo
     */
    public $subInstInvoiceInfo;

    /**
     * @description 子机构门店信息
     *
     * @var subInstShopInfo
     */
    public $subInstShopInfo;
    protected $_name = [
        'bindingAlipayLogonId' => 'bindingAlipayLogonId',
        'contactInfo'          => 'contactInfo',
        'instId'               => 'instId',
        'legalPersonCertInfo'  => 'legalPersonCertInfo',
        'outTradeNo'           => 'outTradeNo',
        'payChannel'           => 'payChannel',
        'qualificationInfos'   => 'qualificationInfos',
        'services'             => 'services',
        'settleInfo'           => 'settleInfo',
        'solution'             => 'solution',
        'subInstAddressInfo'   => 'subInstAddressInfo',
        'subInstAuthInfo'      => 'subInstAuthInfo',
        'subInstBasicInfo'     => 'subInstBasicInfo',
        'subInstCertifyInfo'   => 'subInstCertifyInfo',
        'subInstId'            => 'subInstId',
        'subInstInvoiceInfo'   => 'subInstInvoiceInfo',
        'subInstShopInfo'      => 'subInstShopInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindingAlipayLogonId) {
            $res['bindingAlipayLogonId'] = $this->bindingAlipayLogonId;
        }
        if (null !== $this->contactInfo) {
            $res['contactInfo'] = null !== $this->contactInfo ? $this->contactInfo->toMap() : null;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->legalPersonCertInfo) {
            $res['legalPersonCertInfo'] = null !== $this->legalPersonCertInfo ? $this->legalPersonCertInfo->toMap() : null;
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->qualificationInfos) {
            $res['qualificationInfos'] = [];
            if (null !== $this->qualificationInfos && \is_array($this->qualificationInfos)) {
                $n = 0;
                foreach ($this->qualificationInfos as $item) {
                    $res['qualificationInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->services) {
            $res['services'] = $this->services;
        }
        if (null !== $this->settleInfo) {
            $res['settleInfo'] = null !== $this->settleInfo ? $this->settleInfo->toMap() : null;
        }
        if (null !== $this->solution) {
            $res['solution'] = $this->solution;
        }
        if (null !== $this->subInstAddressInfo) {
            $res['subInstAddressInfo'] = null !== $this->subInstAddressInfo ? $this->subInstAddressInfo->toMap() : null;
        }
        if (null !== $this->subInstAuthInfo) {
            $res['subInstAuthInfo'] = null !== $this->subInstAuthInfo ? $this->subInstAuthInfo->toMap() : null;
        }
        if (null !== $this->subInstBasicInfo) {
            $res['subInstBasicInfo'] = null !== $this->subInstBasicInfo ? $this->subInstBasicInfo->toMap() : null;
        }
        if (null !== $this->subInstCertifyInfo) {
            $res['subInstCertifyInfo'] = null !== $this->subInstCertifyInfo ? $this->subInstCertifyInfo->toMap() : null;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->subInstInvoiceInfo) {
            $res['subInstInvoiceInfo'] = null !== $this->subInstInvoiceInfo ? $this->subInstInvoiceInfo->toMap() : null;
        }
        if (null !== $this->subInstShopInfo) {
            $res['subInstShopInfo'] = null !== $this->subInstShopInfo ? $this->subInstShopInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConsultCreateSubInstitutionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindingAlipayLogonId'])) {
            $model->bindingAlipayLogonId = $map['bindingAlipayLogonId'];
        }
        if (isset($map['contactInfo'])) {
            $model->contactInfo = contactInfo::fromMap($map['contactInfo']);
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['legalPersonCertInfo'])) {
            $model->legalPersonCertInfo = legalPersonCertInfo::fromMap($map['legalPersonCertInfo']);
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['qualificationInfos'])) {
            if (!empty($map['qualificationInfos'])) {
                $model->qualificationInfos = [];
                $n                         = 0;
                foreach ($map['qualificationInfos'] as $item) {
                    $model->qualificationInfos[$n++] = null !== $item ? qualificationInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['services'])) {
            if (!empty($map['services'])) {
                $model->services = $map['services'];
            }
        }
        if (isset($map['settleInfo'])) {
            $model->settleInfo = settleInfo::fromMap($map['settleInfo']);
        }
        if (isset($map['solution'])) {
            $model->solution = $map['solution'];
        }
        if (isset($map['subInstAddressInfo'])) {
            $model->subInstAddressInfo = subInstAddressInfo::fromMap($map['subInstAddressInfo']);
        }
        if (isset($map['subInstAuthInfo'])) {
            $model->subInstAuthInfo = subInstAuthInfo::fromMap($map['subInstAuthInfo']);
        }
        if (isset($map['subInstBasicInfo'])) {
            $model->subInstBasicInfo = subInstBasicInfo::fromMap($map['subInstBasicInfo']);
        }
        if (isset($map['subInstCertifyInfo'])) {
            $model->subInstCertifyInfo = subInstCertifyInfo::fromMap($map['subInstCertifyInfo']);
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['subInstInvoiceInfo'])) {
            $model->subInstInvoiceInfo = subInstInvoiceInfo::fromMap($map['subInstInvoiceInfo']);
        }
        if (isset($map['subInstShopInfo'])) {
            $model->subInstShopInfo = subInstShopInfo::fromMap($map['subInstShopInfo']);
        }

        return $model;
    }
}
